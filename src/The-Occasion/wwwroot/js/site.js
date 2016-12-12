// Write your Javascript code.

    $("#findButton").on("click", function (e) {
        console.log("find button clicked");
        $(".findselect").removeClass("hidden");
    });


    $("#Forms_FormId").on("change", function (e) {
        console.log("form selected, this is its value", $(this).val());
        var chosenForm = $(this).val();
        $.ajax({
            url: `Poem/Form/${chosenForm}`,
            method: "GET"
        }).done((result) => {
            $("#hereBePoems").empty();
            $("#hereBePoems").append(result);
        });
    });

    $("#Topics_TopicId").on("change", function (e) {
        console.log("topic selected, this is its value", $(this).val());
        var chosenTopic = $(this).val();
        $.ajax({
            url: `Poem/Topic/${chosenTopic}`,
            method: "GET"
        }).done((result) => {
            $("#hereBePoems").empty();
            $("#hereBePoems").append(result);
        });
    });

    $("#Moods_MoodId").on("change", function (e) {
        console.log("mood selected, this is its value", $(this).val());
        var chosenMood = $(this).val();
        $.ajax({
            url: `Poem/Mood/${chosenMood}`,
            method: "GET"
        }).done((result) => {
            $("#hereBePoems").empty();
            $("#hereBePoems").append(result);
        });
    });
