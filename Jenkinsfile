node {
	stage ('Checkout'){
		git 'https://github.com/iuryamicussi/JenkinsIntegration.git'
	}
	stage ('Build'){
		bat '%nuget% restore JenkinsIntegration.sln'
		bat "\"${tool 'MSBuildLocal'}\" JenkinsIntegration.sln /p:Configuration=Release /p:Platform=\"Any CPU\" /p:ProductVersion=1.0.0.${env.BUILD_NUMBER}"
	}
	stage ('Archive'){
		archive 'JenkinsIntegration/bin/Release/**'
	}
}
