#!/bin/bash

sqlplus / as sysdba <<EOF
alter session set container=a08_projectatbm;
INSERT INTO OLS_ADMIN.backup_log (status) VALUES ('Backup started');
EXIT;
EOF


rman target / <<EOF
BACKUP PLUGGABLE DATABASE a08_projectatbm PLUS ARCHIVELOG;
EOF

if [ $? -eq 0 ]; then
    status="Backup successful"
else
    status="Backup failed"
fi

sqlplus / as sysdba <<EOF
alter session set container=a08_projectatbm;
INSERT INTO OLS_ADMIN.backup_log (status) VALUES ('$status');
EXIT;
EOF
