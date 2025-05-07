import '../styles/styles_rad.css';
import React from "react";

function DetailActivity({ activities }) {
    // Разбиваем строку на массив через запятую и удаляем лишние пробелы
    const activityList = Array.isArray(activities)
        ? activities
        : (activities || '').split(',').map(item => item.trim());

    return (
        <div className="activity">
            <h2>Activity</h2>
            <h3>What You Will Do</h3>
            <ul className="list_rad">
                {activityList.length > 0 ? (
                    activityList.map((activity, index) => (
                        <li key={index}>{activity}</li>
                    ))
                ) : (
                    <li>No activities available</li>
                )}
            </ul>
            <hr className="line_rad"/>
        </div>
    );
}

export default DetailActivity;