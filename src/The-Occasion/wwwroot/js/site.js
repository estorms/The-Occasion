// Write your Javascript code.

var images = ['birds1.jpg', 'birds2.jpg', 'birds3.jpg', 'birds4.jpg', 'birds5.jpg', 'birds6.jpg'];
var splashImg = images[Math.floor(Math.random() * images.length)];

    $("body").css({ "background-image": `url(../images/${splashImg})` });


    $("#findButton").on("click", function (e) {
        console.log("find button clicked");
        $(".browse").removeClass("hidden");
        $("#findButton").addClass("hidden");
        $("#bored").addClass("hidden");
        $("#makePoem").addClass("hidden");
        $("#curebutt").addClass("hidden");
        $("#makeHaiku").addClass("hidden");
        $("#myPoems").addClass("hidden");
        $("#hereBePoems").empty();
        //$("html").addClass("full-height");    
    });

    $("#curebutt").on("click", function (e) {
        //$("#hereBePoems").empty();
    
        $(".picky").removeClass("hidden");
        $("#CurateMe").removeClass("hidden");
        $("#findButton").addClass("hidden");
        $("#bored").addClass("hidden");
        $("#makePoem").addClass("hidden");
        $("#curebutt").addClass("hidden");
        $("#makeHaiku").addClass("hidden");
        $("#myPoems").addClass("hidden");
        //$("html").addClass("full-height");
        
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
            $("body").css('background-image', ' url(/images/birds1.jpg)');
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
            $("#curebutt").addClass("hidden");
            $("#hereBePoems").empty();
            $("#hereBePoems").append(result);
            $(".findselect").addClass("hidden");
            $("body").css('background-image', 'url(/images/birds1.jpg)');
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
                //$("body").css({ 'background-color': '#d9534f' });
                $("body").css('background-image', 'url(/images/birds1.jpg)');
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
                //$("body").css({ 'background-color': '#d9534f' });
                $("body").css('background-image', 'url(/images/birds1.jpg)');
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
                //$("body").css({ 'background-color': '#d9534f' });
                $("body").css('background-image', 'url(/images/birds1.jpg)');
            });   
    });


    $("#update").on("click", function (e) {
        var poemIdFromJQ = $("#poemId").val();
        var existingLinesArray = $("input[id='linesDiv']")
               .map(function () { return $(this).val(); }).get();
        var editedLinesArray = $("input[id='edit-input']")
               .map(function () { return $(this).val(); }).get();
        var newPoemArray = existingLinesArray.slice();

        for (var i = 0; i < editedLinesArray.length; i++) {
            if (editedLinesArray[i] !== "") {
                newPoemArray.splice(i, 1, editedLinesArray[i]);
            }
        }
        var newPoemToString = newPoemArray.toString();
        console.log(newPoemToString, "newPoemtoString");
        var newPoemRevisedString = newPoemToString.replace(/,/g, "@@");
        console.log(newPoemRevisedString, "newPoemRevisedString");
        var poem = {
            PoemId : poemIdFromJQ,
            Title: $(".title").html(),
            Author: $(".author").html(),
            Lines : newPoemRevisedString
        }
        updatePoem(poem).then(function () {
            console.log('promise resolved, inside then')
            window.location.href ="/Home/Index";
        });
    });
      
   

    $(".edit").on("click", function (e) {
        console.log('edit poem clicked');
        event.preventDefault();
        $(this).prev().removeClass("hidden");
        $(this).addClass("hidden");
    });

    function updatePoem(poem) {
        return new Promise(function (resolve, reject) {
            $.ajax({
                url: "/Poem/UpdatePoem",
                method: "POST",
                contentType: "application/json",
                data: JSON.stringify(poem)
            }).done(function(result) {
                resolve(result)
            }).error(function (err) {
                reject(err);
            })

            })
    }


 
   

  
         