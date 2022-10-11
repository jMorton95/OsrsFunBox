import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import App from './App';
import reportWebVitals from './reportWebVitals';

const root = ReactDOM.createRoot(document.getElementById('root'));

const url = "https://localhost:7033/api/osrs";
const nums = {a:2, b:3000, c:3051};


const getData = async (id) => {
  const data = await fetch(`${url}?id=${id}`)
  const parsed = data.text();
  return parsed;
}

const logData = async (ids) => {
  for (const num in ids) {
   console.log(await getData(ids[num]));
    }
  }
  
logData(nums);


root.render(
  <React.StrictMode>
    <App />
  </React.StrictMode>
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
