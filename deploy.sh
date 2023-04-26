#!/bin/bash

eval `ssh-agent -s`
ssh-add ~/.ssh/id_ed25519

PROJECTS_PATH="";
PROJECT_NAME="";

while getopts p:n: flag
do
    case "${flag}" in
        p) PROJECTS_PATH=${OPTARG};;
        n) PROJECT_NAME=${OPTARG};;
    esac
done

echo 'Updating project...'

ssh -F ~/.ssh/config vm rm -rf $PROJECTS_PATH/$PROJECT_NAME/*
scp -F ~/.ssh/config -r $PROJECTS_PATH/$PROJECT_NAME/* vm:$PROJECTS_PATH/$PROJECT_NAME/

ssh-agent -k