# pipeline-apk-build-unity

Build APK with CI/CD Pipeline

This project automates APK builds for Unity projects using Azure Pipelines. It’s designed for setups where the agent pool runs on a Windows Server. The pipeline uses a YAML configuration and a Unity build script to streamline the build process.

(here are the complete detailed steps to create your Windows agent and Azure agent pool 👉 https://learn.microsoft.com/en-us/azure/devops/pipelines/agents/windows-agent?view=azure-devops)
 

# Features
Automated APK builds on push to the main branch

Uses Unity CLI for headless builds

Copies the final APK to the desktop

Logs build output for easy debugging

Suitable for Windows Server agent pools


- Create the same azure-pipeline.yaml file at the root of your repository.

- Create the same BuildScript.cs at Assets/Editor/ .


# Usage
Push changes to the main branch to trigger the pipeline.

The APK will be generated and copied to the desktop after a successful build.

Check the unity.log file for detailed build information.

### Before use, customize the Buildscript.cs and azure-pipeline.yaml file according to your project 


Happy Building! :)
