-- TO DO - SE E' PRESENTE LO SCRIPT - STOP EXECUTION
INSERT INTO `DbScriptMigration` (`MigrationId`, `MigrationName`, `MigrationDate`)
SELECT * FROM (SELECT UUID(),'001_CreateQueueTable',NOW()) AS tmp
WHERE NOT EXISTS (
    SELECT `MigrationName` FROM `DbScriptMigration` WHERE `MigrationName` = '001_CreateQueueTable'
) LIMIT 1;



CREATE TABLE `queue_types` (
  `id` int NOT NULL,
  `name` varchar(45) NOT NULL,
  `description` varchar(250) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;


CREATE TABLE `queue_status` (
  `id` int NOT NULL,
  `name` varchar(45) NOT NULL,
  `description` varchar(250) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;


CREATE TABLE `queue_actions` (
  `id` int NOT NULL,
  `name` varchar(45) NOT NULL,
  `description` varchar(250) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `queues` (
  `id` bigint NOT NULL AUTO_INCREMENT,
  `execute_date` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `parent_id` bigint DEFAULT NULL,
  `type_id` int NOT NULL,
  `action_id` int NOT NULL,
  `status_id` int NOT NULL,
  `payload` varchar(1000) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_queue_status_idx` (`status_id`),
  KEY `fk_queue_type_idx` (`type_id`),
  KEY `fk_queue_action_idx` (`action_id`),
  KEY `fk_queue_parent_idx` (`parent_id`),
  CONSTRAINT `fk_queue_action` FOREIGN KEY (`action_id`) REFERENCES `queue_actions` (`id`),
  CONSTRAINT `fk_queue_parent` FOREIGN KEY (`parent_id`) REFERENCES `queues` (`id`),
  CONSTRAINT `fk_queue_status` FOREIGN KEY (`status_id`) REFERENCES `queue_status` (`id`),
  CONSTRAINT `fk_queue_type` FOREIGN KEY (`type_id`) REFERENCES `queue_types` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;


CREATE TABLE `queue_targets` (
  `id` bigint NOT NULL AUTO_INCREMENT,
  `queue_id` bigint NOT NULL,
  `entity_id` bigint NOT NULL,
  `entity_type_id` bigint DEFAULT NULL,
  `status_id` int DEFAULT NULL,
  `execute_date` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  KEY `fk_target_queue_idx` (`queue_id`),
  CONSTRAINT `fk_target_queue` FOREIGN KEY (`queue_id`) REFERENCES `queues` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `queue_logs` (
  `id` bigint NOT NULL AUTO_INCREMENT,
  `queue_id` bigint NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_queue_idx` (`queue_id`),
  CONSTRAINT `fk_queue_log` FOREIGN KEY (`queue_id`) REFERENCES `queues` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `queue_log_type` (
  `id` int NOT NULL,
  `name` varchar(45) NOT NULL,
  `description` varchar(250) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;


CREATE TABLE `queue_log_items` (
  `id` bigint NOT NULL AUTO_INCREMENT,
  `log_id` bigint NOT NULL,
  `message` varchar(1000) DEFAULT NULL,
  `log_type_id` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_log_queue_idx` (`log_id`) /*!80000 INVISIBLE */,
  KEY `fk_log_type_idx` (`log_type_id`),
  CONSTRAINT `fk_log_queue` FOREIGN KEY (`log_id`) REFERENCES `queue_logs` (`queue_id`),
  CONSTRAINT `fk_log_queue_type` FOREIGN KEY (`log_type_id`) REFERENCES `queue_log_type` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

