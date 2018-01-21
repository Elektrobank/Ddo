
function toggleCheck(source) {
    var checkboxes = document.getElementsByName('myCheckbox');
    for (var i = 0; i < checkboxes.length; i++)
        checkboxes[i].checked = source.checked;
}

function filterSearch(id, colNum) {

    var input, filter, table, tr, td, i;
    input = document.getElementById(id);
    filter = input.value.toUpperCase();
    table = document.getElementById("myTable");
    tr = table.getElementsByTagName("tr");

    for (i = 0; i < tr.length; i++) {
        td = tr[i].getElementsByTagName("td")[colNum];
        if (td) {
            if (td.innerHTML.toUpperCase().indexOf(filter) > -1) {
                tr[i].style.display = "";
            } else {
                tr[i].style.display = "none";
            }
        }
        
    }

}