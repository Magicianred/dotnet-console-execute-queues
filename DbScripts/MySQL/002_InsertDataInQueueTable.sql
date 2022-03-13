-- TO DO - SE E' PRESENTE LO SCRIPT - STOP EXECUTION
INSERT INTO `DbScriptMigration` (`MigrationId`, `MigrationName`, `MigrationDate`)
SELECT * FROM (SELECT UUID(),'002_InsertDataInQueueTable',NOW()) AS tmp
WHERE NOT EXISTS (
    SELECT `MigrationName` FROM `DbScriptMigration` WHERE `MigrationName` = '002_InsertDataInQueueTable'
) LIMIT 1;


INSERT INTO `queue_types`
    (`id`, `name`, `description`)
    VALUES 
    ('1', 'Normal', 'Normal queue'),
    ('2', 'With Sub Queue', 'A normal queue with sub process to do');

INSERT INTO `queue_status`
    (`id`, `name`, `description`)
    VALUES
    ('0', 'Idle', 'A queue that doesn\'t execute'),
    ('1', 'To Do', 'A queue that to be processed'),
    ('2', 'In progress', 'A queue that is processing'),
    ('3', 'Complete', 'A queue that has completed'),
    ('-1', 'Error', 'A queue that has errors');

INSERT INTO `queue_actions`
    (`id`, `name`, `description`)
    VALUES
    ('1', 'Publish post', 'A queue to publish post(s)t'),
    ('2', 'Remove deleted post', 'A queue for remove deleted posts');

