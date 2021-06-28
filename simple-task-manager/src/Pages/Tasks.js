import axios from 'axios';

const tasks = [
    {
        name: "",
        startDate: "",
        endDate: "",
        status: ""
    }
]

function getTasks() {
    axios.get('https://localhost:44363/api/tasks',
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

function Tasks() {
    return (
        <div>
            <div className="container-fluid">
                <div className="row">
                    <div><h3>Tasks</h3></div>
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
                        <th>Название</th>
                        <th>Дата и время начала</th>
                        <th>Дата и время окончания</th>
                        <th>Статус активности</th>
                    </tr>
                </thead>
                <tbody>
                    {tasks.map((task, index) => (
                        <tr key={index}>
                            <td>{task.name}</td>
                            <td>{task.startDate}</td>
                            <td>{task.endDate}</td>
                            <td>{task.status}</td>
                        </tr>
                    ))}
                </tbody>
            </table>
        </div>
    );
}

export default Tasks;
