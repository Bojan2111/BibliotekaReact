import React, { useState } from "react";

const Biblioteka = () => {
    const [knjige, setKnjige] = useState([]);

    fetch("https://localhost:44373/api/knjige")
        .then(response => response.json())
        .then((data) => {
            setKnjige(data);
        });

    return (
        <div>
            <div>
                <h1>Biblioteka</h1>
            </div>
            <div>
                {knjige !== [] ? <h3>Loading . . .</h3> : <table className="table table-hover">
                    <tr>
                        <th>Knjiga</th>
                        <th>Autor</th>
                        <th>Clan</th>
                    </tr>
                    {knjige.map((knjiga) => {
                        <tr>
                            <td>{knjiga.naziv}</td>
                            <td>{knjiga.autor}</td>
                            <td>{knjiga.clanIme + " " + knjiga.clanPrezime}</td>
                        </tr>
                    })}
                </table>}
            </div>
        </div>
    );
}

export default Biblioteka;