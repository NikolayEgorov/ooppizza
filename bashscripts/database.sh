#!/bin/bash

echo "<<<<<<<<<<<<<<<<<<<Database Init>>>>>>>>>>>>>>>>>>>"


source $(pwd)/variables.sh

PROJECT_FULL_PATH=$PROJECTS_PATH/$PROJECT_NAME

cd $PROJECT_FULL_PATH

touch "$PROJECT_FULL_PATH"/database/"$PROJECT_NAME".sqlite3
chmod 777 "$PROJECT_FULL_PATH"/database/"$PROJECT_NAME".sqlite3 

echo "<<<<<<<<<<<<<<<<<<<Create Database>>>>>>>>>>>>>>>>>>>>"

dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet ef database update