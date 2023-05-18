node {
  stage('SCM') {
    checkout scm
  }
  stage('SonarQube Analysis') {
    withSonarQubeEnv(installationName: 'sq1') {
      sh "dotnet sonarscanner begin /k:\"CITestNetCore\""
      sh "dotnet build"
      sh "dotnet sonarscanner end"
    }
  }
}