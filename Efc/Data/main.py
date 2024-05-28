import pandas as pd

import sqlite3
from fastapi import FastAPI

app = FastAPI()


@app.get("/")
async def root():
    return CreateExcel()


def CreateExcel():

    conn = sqlite3.connect('DataBase.db')
    print("Connected to SQLite.")

    query = "SELECT * FROM Items"
    data_frame = pd.read_sql(query, conn)
    print(data_frame.head())
    data_frame.to_excel('selected_columns_data.xlsx', index=False)
    print("Selected columns exported to Excel successfully.")