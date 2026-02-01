# 🌦️ Weather App Demo – .NET 8 | Docker | AKS | GitHub Actions

This project demonstrates an end-to-end **cloud-native deployment pipeline** using a .NET 8 Web API, Docker, Azure Kubernetes Service (AKS), Azure Container Registry (ACR), and GitHub Actions for CI/CD.

It showcases modern DevOps best practices: local development, containerization, cloud deployment, and automated delivery.

## 🚀 Architecture Flow

.NET 8 Web API (Local Development & Testing)  
→ Docker Containerization  
→ Azure Container Registry (ACR)  
→ Azure Kubernetes Service (AKS)  
→ Automated CI/CD via GitHub Actions  


## 🛠️ Tech Stack

- **Backend:** .NET 8 (Minimal Web API)
- **Containerization:** Docker
- **Cloud:** Microsoft Azure
  - Azure Kubernetes Service (AKS)
  - Azure Container Registry (ACR)
- **CI/CD:** GitHub Actions
- **Tools:**  
  - Visual Studio Code  
  - Docker Desktop  
  - Azure CLI  
  - kubectl  
  - Git & GitHub CLI  


## 📂 Project Structure

weather-app-demo/
├── WeatherApp/
│ ├── Program.cs
│ └── WeatherApp.csproj
├── k8s/
│ ├── deployment.yaml
│ └── service.yaml
├── Dockerfile
├── .dockerignore
└── README.md

yaml
Copy code

---

## ✅ Features

- Minimal .NET 8 Web API
- Health check endpoint (`/health`)
- Swagger UI for API documentation (`/swagger`)
- Dockerized for consistent runtime
- Deployed to AKS with Kubernetes manifests
- Automated build and deployment using GitHub Actions

---

## 🔗 API Endpoints

| Endpoint | Description |
|--------|------------|
| `/` | Root endpoint |
| `/weather` | Sample weather response |
| `/health` | Application health check |
| `/swagger` | Swagger UI |

---

## 🐳 Run Locally with Docker

```bash
docker build -t weather-app:local .
docker run -p 8080:8080 weather-app:local
Access the app:

http://localhost:8080

http://localhost:8080/swagger

http://localhost:8080/health

☸️ Kubernetes Deployment
bash
Copy code
kubectl apply -f k8s/deployment.yaml
kubectl apply -f k8s/service.yaml
Check status:

bash
Copy code
kubectl get pods
kubectl get services

🔁 CI/CD Pipeline
Triggered on push to main

Builds Docker image

Pushes image to Azure Container Registry

Deploys updated image to AKS automatically


📌 Key Learnings

Building cloud-ready .NET applications

Containerization best practices with Docker

Secure image management using ACR

Kubernetes deployment using declarative manifests

Automating deployments with GitHub Actions

👤 Author
Emmanuel Obinna Onyemuche
Cloud / DevOps Engineer

📄 License
This project is for learning and demonstration purposes.
## 📂 Project Structure

