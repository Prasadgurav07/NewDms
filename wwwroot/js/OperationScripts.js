
function enableTableFilter(tableId) {
    const table = document.getElementById(tableId);
    if (!table) {
        console.error("Table not found:", tableId);
        return;
    }

    const thead = table.querySelector("thead");
    const tbody = table.querySelector("tbody");
    if (!thead || !tbody) {
        console.error("Table missing <thead> or <tbody>:", tableId);
        return;
    }

    const headerRow = thead.querySelector("tr");
    const colCount = headerRow.children.length;

    // Remove existing filter row if any
    const existingFilterRow = thead.querySelector(".filter-row");
    if (existingFilterRow) existingFilterRow.remove();

    // Create a new filter row under headers
    const filterRow = document.createElement("tr");
    filterRow.classList.add("filter-row");
    filterRow.style.backgroundColor = "#f0f0f0";
    filterRow.style.fontSize = "12px";

    for (let i = 0; i < colCount; i++) {
        const th = document.createElement("th");
        const select = document.createElement("select");
        select.innerHTML = '<option value="">All</option>';

        // Function to populate dropdown based on visible rows
        function populateOptions() {
            // Get unique values from visible rows
            const uniqueValues = [...new Set(
                Array.from(tbody.rows)
                    .filter(row => row.style.display !== "none")
                    .map(row => row.cells[i]?.innerText.trim())
                    .filter(val => val)
            )].sort();

            // Clear old options except "All"
            select.innerHTML = '<option value="">All</option>';

            uniqueValues.forEach(val => {
                const opt = document.createElement("option");
                opt.value = val;
                opt.textContent = val;
                select.appendChild(opt);
            });
        }

        // Populate initially
        populateOptions();

        // Add event listener for filtering
        select.addEventListener("change", () => {
            const filters = Array.from(filterRow.querySelectorAll("select")).map(s => s.value);

            Array.from(tbody.rows).forEach(row => {
                let visible = true;
                filters.forEach((val, index) => {
                    if (val) {
                        const cellText = row.cells[index]?.innerText.trim();
                        if (cellText !== val) visible = false;
                    }
                });
                row.style.display = visible ? "table-row" : "none";
            });

            // After filtering, update all dropdowns based on visible rows
            Array.from(filterRow.querySelectorAll("select")).forEach(s => {
                const colIndex = Array.from(filterRow.children).indexOf(s.parentElement);
                // Keep current selection
                const currentValue = s.value;
                // Re-populate options based on visible rows
                const uniqueValues = [...new Set(
                    Array.from(tbody.rows)
                        .filter(row => row.style.display !== "none")
                        .map(row => row.cells[colIndex]?.innerText.trim())
                        .filter(val => val)
                )].sort();

                s.innerHTML = '<option value="">All</option>';
                uniqueValues.forEach(val => {
                    const opt = document.createElement("option");
                    opt.value = val;
                    opt.textContent = val;
                    s.appendChild(opt);
                });
                // Restore previous selection if still available
                if (uniqueValues.includes(currentValue)) s.value = currentValue;
            });
        });

        th.appendChild(select);
        filterRow.appendChild(th);

        // Optionally hide first and last filters
        if (i === 0 || i === colCount - 1) {
            select.style.visibility = "hidden";
        }
    }

    // Insert filter row below the header
    thead.appendChild(filterRow);
}






document.getElementById('WarehouseOperation').addEventListener('click', () => {
    const userid = 123;

    fetch('/Warehouse/Index?userid=${userid}')
        .then(res => res.text())
        .then(html => {
            document.getElementById('content').innerHTML = html;
            enableTableFilter('wl');
        })
        .catch(err => console.error(err));
});


function getreport(report) {
    switch (report) {
        case "srbtn":
            var container = document.getElementById('content');
            container.innerHTML = "<div class='spinner-border'></div><p>Working on it!</p>";
            fetch('/Operation/LoadStockReport')
                .then(res => res.text())
                .then(html => {
                    document.getElementById('content').innerHTML = html;
                    enableTableFilter('stockreporttable');
                })
                .catch(err => console.error(err));
            break;
        case "arbtn":
            var container = document.getElementById('content');
            container.innerHTML = "<div class='spinner-border'></div><p>Working on it!</p>";
            fetch('/Operation/LoadAttendanceReport')
                .then(res => res.text())
                .then(html => {
                    document.getElementById('content').innerHTML = html;
                    enableTableFilter('attendancereporttable');
                })
                .catch(err => console.error(err));
            break;
        default: break;
    }
}

    