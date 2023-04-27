#!/bin/bash

source $(pwd)/variables.sh

echo "<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>"
echo "<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>"
echo "<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>"
echo "<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>"
echo "<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>"
echo "<<<<<<<<<<<<<<<<<<<<<<<<<<Run>>>>>>>>>>>>>>>>>>>>>>>>>>>>>"
echo "<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>"
echo "<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>"
echo "<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>"
echo "<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>"
echo "<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>"

cd $PROJECTS_PATH/$PROJECT_NAME
dotnet tool install --global dotnet-ef
dotnet ef
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 7.0.5

source $(pwd)/bashscripts/build-assets.sh
source $(pwd)/bashscripts/database.sh

chmod -R 777 $PROJECTS_PATH/$PROJECT_NAME

cd $PROJECTS_PATH/$PROJECT_NAME
dotnet run