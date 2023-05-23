node {
  stage('SCM') {
    checkout scm
  }
  stage('SonarQube Analysis') {
    def scannerHome = tool 'SonarScanner for MSBuild'
    withSonarQubeEnv(installationName: 'sq1') {
      sh "dotnet sonarscanner begin /k:\"CITestNetCore\""
      sh "dotnet restore ./CITestNetCore.sln"
      sh "dotnet build"
      sh "dotnet sonarscanner end"
    }
  }
}