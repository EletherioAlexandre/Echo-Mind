from pydantic import BaseModel

class Feedback(BaseModel):
  text: str
