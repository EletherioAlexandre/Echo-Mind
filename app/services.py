from textblob import TextBlob

def analyze_text(text: str):
  blob = TextBlob(text)
  polarity = blob.sentiment.polarity

  sentiment = "Positive" if polarity > 0 else "Negative" if polarity < 0 else "Neutral"
  
  
  return {
    "sentiment": sentiment,
    "polarity": polarity,
    "text": text
  }