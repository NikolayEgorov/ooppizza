#!/bin/bash

echo "<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>"
echo "<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>"
echo "<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>"
echo "<<<<<<<<<<<<<<<<<<Compiling assets>>>>>>>>>>>>>>>>>>>>>>"
echo "<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>"
echo "<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>"
echo "<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>"

source $BASH_SCRIPT_PATH/variables.sh

npm install $PROJECT_FULL_PATH
npm install --global gulp-cli

gulp --gulpfile=$PROJECT_FULL_PATH/gulpfile.js compile

rm -rf $PROJECT_FULL_PATH/node_modules