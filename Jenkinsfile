pipeline {
    agent any
    stages {
        stage('Restore') {
            steps {
                sh 'dotnet restore'
            }
        }
        stage('Clean') {
            steps {
                sh 'dotnet clean'
            }
        }
        stage('Build') {
            steps {
                sh 'dotnet build --configuration Release'
            }
        }
        stage('Test') {
            steps {
                sh 'dotnet test --configuration Release'
            }
        }
    }
}
