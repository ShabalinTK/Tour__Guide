import '../styles/styles_rad.css';
import React from "react";

function DetailSafety({ safety }) {
    const safeSafety = Array.isArray(safety)
        ? safety
        : (safety || '').split(',').map(item => item.trim());

    return (
        <div className="safety">
            <h2>Safety</h2>
            <h3>Health Precautions</h3>
            <ul className="list_rad">
                {safeSafety.length > 0 ? (
                    safeSafety.map((item, index) => (
                        <li key={index}>{item}</li>
                    ))
                ) : (
                    <li>No safety precautions available</li>
                )}
            </ul>
            <hr className="line_rad"/>
        </div>
    );
}

export default DetailSafety;