import axios from 'axios';

const tasks = [
    {
        name: "",
        endDate: ""
    }
]

function getTasks() {
    axios.get('https://localhost:44363/api/tasks/expiring',
        {
            headers: { 'Access-Control-Allow-Origin': '*' }
        })
        .then(function (response) {
            tasks = response.tasks;
        })
        .catch(function (error) {
            console.log(error);
        });
}

function ExpiringTasks() {
    return (
        <div>
            <div className="container-fluid">
                <div className="row">
                    <div><h3>ExpiringTasks</h3></div>
                    <div className="pl-3">
                        <button className="btn btn-primary btn-sm" onClick={()=>getTasks()}>
                            Get tasks
                    </button>
                    </div>
                </div>
            </div>
            <table className="table">
                <thead>
                    <tr>
                        <th>Задача</th>
                        <th>Дата и время окончания</th>
                    </tr>
                </thead>
                <tbody>
                    {tasks.map((task, index) => (
                        <tr key={index}>
                            <td>{task.name}</td>
                            <td>{task.endDate}</td>
                        </tr>
                    ))}
                </tbody>
            </table>
        </div>
    );
}

export default ExpiringTasks;
