#!/bin/bash

eval `ssh-agent -s`
ssh-add ~/.ssh/id_rsa

PROJECTS_PATH="/home/mykola/dotNetProjects"
PROJECT_NAME="collections"

echo 'updating project...'

ssh -F ~/.ssh/config vm rm -rf $PROJECTS_PATH/$PROJECT_NAME/*
scp -F ~/.ssh/config -r $PROJECTS_PATH/$PROJECT_NAME/* vm:$PROJECTS_PATH/$PROJECT_NAME/

ssh-agent -k