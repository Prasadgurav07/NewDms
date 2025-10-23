// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.
<script>
   


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

    // Create a new filter row under headers
    const filterRow = document.createElement("tr");

    for (let i = 0; i < colCount; i++) {
        const th = document.createElement("th");
    const select = document.createElement("select");
    select.innerHTML = '<option value="">All</option>';

    // Get unique values for this column
    const uniqueValues = [...new Set(
    Array.from(tbody.rows)
     .map(row => row.cells[i]?.innerText.trim())
    )].sort();

        uniqueValues.forEach(val => {
          const opt = document.createElement("option");
    opt.value = val;
    opt.textContent = val;
    select.appendChild(opt);
        });

        // Add event listener for filtering
           select.addEventListener("change", () => {
        // 1. Get selected value for each column
        const filters = Array.from(filterRow.querySelectorAll("select")).map(s => s.value);

        // 2. Loop over all table rows
        Array.from(tbody.rows).forEach(row => {
        let visible = true;

            filters.forEach((val, index) => {
                // Only check if a filter is selected
                if (val) {
                    const cellText = row.cells[index]?.innerText.trim(); // safe access
    if (cellText !== val) visible = false;
                }
            });

    // 3. Show or hide row
    row.style.display = visible ? "" : "none";
        });
    });

    th.appendChild(select);
    filterRow.appendChild(th);
      }

    // Insert filter row below the header

    thead.appendChild(filterRow);
    }

</script>
