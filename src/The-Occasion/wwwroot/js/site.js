// Write your Javascript code.
$("#findButton").on("click", function (e) {
    console.log("find button clicked");
    $(".findselect").removeClass("hidden");
});


$("#Forms_FormId").on("change", function (e) {
    console.log("form selected, this is its value", $(this).val());
    $.ajax({
        url: `/Poem/Form/${$(this).val()}`,
        method: "GET"
    }).done((result) => {
        console.log(result);
    });
});

    $("#Topics_TopicId").on("change", function (e) {
        console.log("topic selected, this is its value", $(this).val());
        $.ajax({
            url: `/Poem/Topic/${$(this).val()}`,
            method: "GET"
        }).done((result) => {
            console.log(result);
        });
    });

    $("#Moods_MoodId").on("change", function (e) {
        console.log("mood selected, this is its value", $(this).val());
       
        $.ajax({
            url: `/Poem/Mood/${$(this).val()}`,
            method: "GET"
        }).done((result) => {
             console.log(result);
        });
    });