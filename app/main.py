from fastapi import FastAPI
from app.services import analyze_text
from app.models import Feedback


app = FastAPI()

# http://127.0.0.1:8000/docs

@app.post("/analyze")
def analyze_sentiment(feedback: Feedback):
  return analyze_text(feedback.text)