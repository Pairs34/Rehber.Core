$(function () {

    $("#btnAddNewPerson").click(function() {
        alert("test");
    });

    $("a.contactEdit").on("click",
        function() {
            var modal = $("#modalEdit");
            var id = $(this).closest("tr").find("td.id").html();
            var name = $(this).closest("tr").find("td.name").html();
            var departman = $(this).closest("tr").find("td.department").html();
            var internalNumber = $(this).closest("tr").find("td.internal-number").html();
            var mobileNumber = $(this).closest("tr").find("td.mobile-number").html();
            var shortNumber = $(this).closest("tr").find("td.short-number").html();
            var isMudur = $(this).closest("tr").find("td.short-number").html();

            $("#txtKisiAdi", modal).val(name);
            $("#txtDepartment", modal).val(departman);
            $("#txtLocalNumber", modal).val(internalNumber);
            $("#txtMobileNumber", modal).val(mobileNumber);
            $("#txtShortnumber", modal).val(shortNumber);
            $("#isMudur", modal).val(isMudur);
            $("#kisiId", modal).val(id);

            modal.modal({ show: true });

            return false;
        });
});