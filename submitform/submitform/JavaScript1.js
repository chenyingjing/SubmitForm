$(function () {
    
    $("#click1").click(function () {
        console.log("click1 on click");
        $.post("Handler2.ashx",
            { abc: "hellodata1" },
            function (result) {
                alert(result);
                location.reload();
            });
    });
    $("#click2").click(function () {
        console.log("click2 on click");
        $.post("Handler4.ashx",
            { abc: "hellodata1" },
            function (result) {
                $("#textarea1").val(result);
            });
        
    });
});