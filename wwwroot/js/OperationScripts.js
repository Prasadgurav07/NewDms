document.getElementById('WarehouseOperation').addEventListener('click', () => {
    const userid = 123;

    fetch(`/Warehouse/Index?userid=${userid}`)
        .then(res => res.text())
        .then(html => {
            document.getElementById('content').innerHTML = html;
            //enableTableFilter('employeeTable');
        })
        .catch(err => console.error(err));
});