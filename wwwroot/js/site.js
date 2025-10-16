// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.
<script>
    document.addEventListener("DOMContentLoaded", function () {

        // When "By State" is clicked
        document.getElementById("ByState").onclick = function () {
            document.getElementById("statewise").style.display = "block";
            document.getElementById("warehousewise").style.display = "none";
        };

    // When "By Warehouse" is clicked
    document.getElementById("ByWarehouse").onclick = function () {
        document.getElementById("statewise").style.display = "none";
    document.getElementById("warehousewise").style.display = "block";
    };

    // When "By CCM" is clicked
    document.getElementById("ByCCM").onclick = function () {
        document.getElementById("statewise").style.display = "none";
    document.getElementById("warehousewise").style.display = "none";
    };

});
</script>
