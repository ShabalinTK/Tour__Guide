import '../styles/styles_rad.css';
import React from "react";

function DetailIncludes({ includes }) {
    const safeIncludes = Array.isArray(includes?.Includes)
        ? includes.Includes
        : (includes?.Includes || '').split(',').map(item => item.trim());

    const safeNotIncludes = Array.isArray(includes?.NotIncludes)
        ? includes.NotIncludes
        : (includes?.NotIncludes || '').split(',').map(item => item.trim());

    return (
        <div className="includes">
            <h2>What Is Included / Not Included</h2>
            <div className="includes__container_rad">
                <div className="includes__column_rad">
                    <h3>Includes</h3>
                    <ul className="list_rad">
                        {safeIncludes.length > 0 ? (
                            safeIncludes.map((item, index) => (
                                <li key={index}>{item}</li>
                            ))
                        ) : (
                            <li>No included items</li>
                        )}
                    </ul>
                </div>
                <div className="includes__column_rad">
                    <h3>Not Includes</h3>
                    <ul className="list_rad">
                        {safeNotIncludes.length > 0 ? (
                            safeNotIncludes.map((item, index) => (
                                <li key={index}>{item}</li>
                            ))
                        ) : (
                            <li>No excluded items</li>
                        )}
                    </ul>
                </div>
            </div>
            <hr className="line_rad"/>
        </div>
    );
}

export default DetailIncludes;