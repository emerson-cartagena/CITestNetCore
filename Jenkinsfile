node {
  stage('SCM') {
    checkout scm
  }
  stage('SonarQube Analysis') {
    def scannerHome = tool 'SonarScanner for MSBuild'
    withSonarQubeEnv(installationName: 'sq1') {
      sh "dotnet ${scannerHome}/SonarScanner.MSBuild.dll begin /k:\"CITestNetCore\""
      sh "dotnet restore"
      sh "dotnet build"
      sh "dotnet ${scannerHome}/SonarScanner.MSBuild.dll end"
    }
  }
}