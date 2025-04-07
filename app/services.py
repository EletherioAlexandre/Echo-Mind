from textblob import TextBlob

def analyze_text(text: str):
  blob = TextBlob(text)
  polarity = blob.sentiment.polarity

  sentiment = "Positivo" if polarity > 0 else "Negativo" if polarity < 0 else "Neutro"
  
  
  return {
    "sentiment": sentiment,
    "polarity": polarity,
    "text": text
  }