#!/bin/bash

echo "Compiling assets..."

PROJECTS_PATH="/home/mykola/dotNetProjects"
PROJECT_NAME="collections"

npm install $PROJECTS_PATH/$PROJECT_NAME
npm install --global gulp-cli

gulp --gulpfile=$PROJECTS_PATH/$PROJECT_NAME/gulpfile.js compile

rm -rf $PROJECTS_PATH/$PROJECT_NAME/node_modules