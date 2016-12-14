// Write your Javascript code.

    $("#findButton").on("click", function (e) {
        console.log("find button clicked");
        $(".findselect").removeClass("hidden");
        $("#findButton").addClass("hidden");
        $("#bored").addClass("hidden");
        $("#makePoem").addClass("hidden");
        $("#myPoems").addClass("hidden");
        $("#hereBePoems").empty();
    });

    $("#SaveBored").on("click", function (e) {
        console.log("save button clicked clicked");
        $.ajax({
            url: `Poem/SaveBored/${$(this).val()}`,
        method: "POST",
        contentType: 'application/json; charset=utf-8'
        }).done((result) => {
        });
    });

    $("#Save").on("click", function (e) {
        console.log("save button clicked clicked");
        console.log("this.value", $(this).val());
        $.ajax({
            url: `/Poem/Save/${$(this).val()}`,
            method: "POST",
            contentType: 'application/json; charset=utf-8'
        }).done((result) => {
            console.log("result", result);
        $("#Save").addClass("hidden");
        });
    });
    $("#Delete").on("click", function (e) {
        console.log("delete button clicked");
        $.ajax({
            url: `/Poem/Delete/${$(this).val()}`,
            method: "DELETE",
            contentType: 'application/json; charset=utf-8'
        }).done((result) => {
           console.log(result)
        });
    });

    $("#bored").on("click", function (e) {
        console.log("bored button clicked");
        $.ajax({
            url: `Poem/Bored/`,
            method: "GET"
        }).done((result) => {
            $("#findButton").addClass("hidden");
            $("#bored").addClass("hidden");
            $("#makePoem").addClass("hidden");
            $("#myPoems").addClass("hidden");
            $("#hereBePoems").empty();
            $("#hereBePoems").append(result);
        });
    });

    //$("#myPoems").on("click", function (e) {
    //    console.log("my poems button clicked");
    //    //$.ajax({
    //    //    url: `Poem/MyPoems/`,
    //    //    method: "GET"
    //    //}).done((result) => {
    //        $("#findButton").addClass("hidden");
    //        $("#bored").addClass("hidden");
    //        $("#makePoem").addClass("hidden");
    //        $("#myPoems").addClass("hidden");
    //        //$("#hereBePoems").empty();
    //        //$("#hereBePoems").append(result);
    //    //});
    //});

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
