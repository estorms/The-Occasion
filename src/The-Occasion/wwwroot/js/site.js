// Write your Javascript code.

var images = ['birds1.jpg', 'birds2.jpg', 'birds3.jpg', 'birds4.jpg', 'birds5.jpg', 'birds6.jpg'];
var splashImg = images[Math.floor(Math.random() * images.length)];
$("body").css({ "background-image": `url(/images/${splashImg})` });


    $("#findButton").on("click", function (e) {
        console.log("find button clicked");
        $(".findselect").removeClass("hidden");
        $("#findButton").addClass("hidden");
        $("#bored").addClass("hidden");
        $("#makePoem").addClass("hidden");
        $("#curateview").addClass("hidden");
        $("#makeHaiku").addClass("hidden");
        $("#myPoems").addClass("hidden");
        $("#hereBePoems").empty();
        $("html").addClass("full-height");
        
    });

    $("#SaveBored").on("click", function (e) {
        console.log("save buttonbored clicked clicked");
        $.ajax({
            url: `Poem/SaveBored/${$(this).val()}`,
        method: "POST",
        contentType: 'application/json; charset=utf-8'
        }).done((result) => {
            $("#DeleteBored").removeClass("hidden");
            $("#SaveBored").addClass("hidden");
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
            $("#Delete").removeClass("hidden");
           
        });
    });

    $("#Moods_Id").on("change", function (e) {
         mood = $(this).val();
        console.log("mood", mood);
    });

    $("#Topics_Id").on("change", function (e) {
         topic = $(this).val();
        console.log("topic", topic);
    });
  
    $("#Forms_Id").on("change", function (e) {
         form = $(this).val();
        console.log("form", form);
    });

    $("#CurateMe").on("click", function (e) {
        console.log("curate me clicked");
        console.log(mood + form + topic);
        $.ajax({
            url: `/Poem/Curate/${mood}/${topic}/${form}`,
            method: "GET",
        }).done((result) => {
            console.log("result", result);
            $("#hereBePickyPoems").html(" ");
            $("#hereBePickyPoems").append(result);
            $("#CurateMe").addClass("hidden");
            $("#Moods_Id").addClass("hidden");
            $("#Topics_Id").addClass("hidden");
            $("#Forms_Id").addClass("hidden");
            $("#hereBePoems").empty();
        });
    });

    $("#Delete").on("click", function (e) {
        console.log("delete button clicked");
        $.ajax({
            url: `/Poem/Delete/${$(this).val()}`,
            method: "DELETE",
        }).done((result) => {
            console.log(result);
            $("#Delete").addClass("hidden");
            $("#Save").removeClass("hidden");
        });
    });

        $("#DeleteBored").on("click", function (e) {
        console.log("delete bored button clicked");
        $.ajax({
            url: `/Poem/Delete/${$(this).val()}`,
            method: "DELETE"
        }).done((result) => {
            console.log(result);
            $("#DeleteBored").addClass("hidden");
            $("#SaveBored").removeClass("hidden");
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
            $("#makeHaiku").addClass("hidden");
            $("#myPoems").addClass("hidden");
            $("#curateview").addClass("hidden");
            $("#hereBePoems").empty();
            $("#hereBePoems").append(result);
        });
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
                $(".findselect").addClass("hidden");
                $("body").css({ 'background-color': '#ffffff' });
                $("body").css('background-image', 'none');
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
                $(".findselect").addClass("hidden");
                //$("html").removeClass("full-height");
                $("body").css({ 'background-color': '#ffffff' });
                $("body").css('background-image', 'none');
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
                $(".findselect").addClass("hidden");
                $("#myPoems").addClass("hidden");
                $("body").css({ 'background-color': '#ffffff' });
                $("body").css('background-image', 'none');
            });   
    });

    $("#curateview").on("click", function (e) {
        $("html").addClass("full-height");
    });

 
   

  
          