#!/bin/bash
rman target / <<EOF
RUN {
  ALTER PLUGGABLE DATABASE a08_projectatbm CLOSE;
  RESTORE PLUGGABLE DATABASE a08_projectatbm;
  RECOVER PLUGGABLE DATABASE a08_projectatbm;
  ALTER PLUGGABLE DATABASE a08_projectatbm OPEN;
}
EOF

