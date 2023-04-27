#!/bin/bash

echo "<<<<<<<<<<<<<<<<<<Compiling assets>>>>>>>>>>>>>>>>>>>>>>"

source $(pwd)/variables.sh

FULL_PATH=$PROJECTS_PATH/$PROJECT_NAME

npm install $FULL_PATH
npm install --global gulp-cli

gulp --gulpfile=$FULL_PATH/gulpfile.js compile

rm -rf $FULL_PATH/node_modules