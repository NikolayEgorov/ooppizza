#!/bin/bash

source $BASH_SCRIPT_PATH/variables.sh

if [ "$DATABASE_REINIT" -eq 1 ]
then
    echo "<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>"
    echo "<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>"
    echo "<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>"
    echo "<<<<<<<<<<<<<<<<<<<Database Inint>>>>>>>>>>>>>>>>>>>>>>>"
    echo "<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>"
    echo "<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>"
    echo "<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>"

    rm -rf "$PROJECT_FULL_PATH"/database

    mkdir "$PROJECT_FULL_PATH"/database
    touch "$PROJECT_FULL_PATH"/database/"$PROJECT_NAME".sqlite3
    chmod 777 -R "$PROJECT_FULL_PATH"/database

    echo "<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>"
    echo "<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>"
    echo "<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>"
    echo "<<<<<<<<<<<<<<<<<<<Create Database>>>>>>>>>>>>>>>>>>>>>>"
    echo "<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>"
    echo "<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>"
    echo "<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>"

    cd $PROJECT_FULL_PATH
    dotnet ef database update
fi