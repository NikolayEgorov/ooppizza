#!/bin/bash

PROJECTS_PATH="";
PROJECT_NAME="";
WITH_BUILD=0;

while getopts p:n:c: flag
do
    case "${flag}" in
        p) PROJECTS_PATH=${OPTARG};;
        n) PROJECT_NAME=${OPTARG};;
        c) WITH_BUILD=${OPTARG};;
    esac
done

if [ "$WITH_BUILD" -eq 1 ]
then
    source $PROJECTS_PATH/$PROJECT_NAME/bashscripts/build.sh
fi

cd $PROJECTS_PATH/$PROJECT_NAME
dotnet run