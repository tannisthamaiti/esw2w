from flask import Flask,request, jsonify
from utils import model_predict
app = Flask(__name__)
in_memory_datastore = {
   "COBOL" : {"name": "COBOL", "publication_year": 1960, "contribution": "record data"},
   "ALGOL" : {"name": "ALGOL", "publication_year": 1958, "contribution": "scoping and nested functions"},
   "APL" : {"name": "APL", "publication_year": 1962, "contribution": "array processing"},
}
@app.route("/")
def home():
    return "Hello, Flask!"
 
@app.get('/programming_languages')
def list_programming_languages():
   return {"programming_languages":list(in_memory_datastore.values())}

# Create an API endpoint
@app.route('/api/predict', methods=['POST'])
def predict_api():
    data = request.get_json(force=True)  # Get data posted as a json
    email = data['content']
    prediction = model_predict(email)
    return jsonify({'prediction': prediction, 'email': email})  # Return prediction

if __name__ == "__main__":
    app.run(host="0.0.0.0", port=8080, debug=True)
