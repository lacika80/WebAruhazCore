$(document).ready(function () {
    //loader();
    $.ajax({
        type: "GET",
        url: "Item/Index",
        cache: false,
        success: function (data) { MainH(data); MainF(); },
        error: function (data) { alert(data.status) }
    });
    
    
});

function MPage() {
    GetCookie();
    $("#Container").empty();
}

function GetCookie() {
    var cookie;
    $.ajax({
        type: "GET",
        url: "Item/Index",
        cache: false,
        success: function (data) { MainH(data); },
        error: function (data) { alert(data.status) }
    });
    return cookie;
}

function MainH(HeadData) {
    $("#header").replaceWith('<nav class="navbar-br navbar navbar-dark bg-dark navbar-width-60pc navbar-expand-lg" id="header"></nav>');
    let header = '';
    switch (HeadData.status) {
        case "guest":
        header += '<nav class="navbar-br navbar navbar-dark bg-dark navbar-width-60pc navbar-expand-lg" id="header">';
        header += '<div class="collapse navbar-collapse">';
        header += '<div class="d-inline-flex justify-content-between w-100">';
        header += '<div>';
        header += '<button type="button" class="btn btn-dark" onclick="MPage()">Main page</button>';
        header += '<button type="button" class="btn btn-dark" id="browsing" onclick="ItemList()">Böngészés</button>';
        header += '</div>';
        header += '<div id="navlogin" class="d-inline-flex justify-content-end">';
        header += '<button type="button" class="btn btn-dark" id="loginButton" onclick="Login()">Login</button>';
        header += '<p class="btn btn-dark" style="margin:auto" id="perbutton">/</p>';
        header += '<button type="button" class="btn btn-dark" id="regbutton" onclick="Register()">registration</button>';
        header += '<button type="button" class="btn btn-dark">Basket</button>';
        header += '</div>';
        header += '</div>';
        header += '</div>';
        header += '</nav>';
            break;
            case "user":
            header += '<nav class="navbar-br navbar navbar-dark bg-dark navbar-width-60pc navbar-expand-lg" id="header">';
        header += '<div class="collapse navbar-collapse">';
        header += '<div class="d-inline-flex justify-content-between w-100">';
        header += '<div>';
        header += '<button type="button" class="btn btn-dark" onclick="MPage()">Main page</button>';
        header += '<button type="button" class="btn btn-dark" id="browsing" onclick="ItemList()">Böngészés</button>';
        header += '</div>';
        header += '<div id="navlogin" class="d-inline-flex justify-content-end">';
        header += '<button type="button" class="btn btn-dark" id="profileButton" onclick="Profile()">Profile</button>';
        header += '<button type="button" class="btn btn-dark" id="profileButton" onclick="Logout()">Logout</button>';
        header += '<button type="button" class="btn btn-dark">Basket</button>';
        header += '</div>';
        header += '</div>';
        header += '</div>';
        header += '</nav>';
            break;
            case "admin":
            header += '<nav class="navbar-br navbar navbar-dark bg-dark navbar-width-60pc navbar-expand-lg" id="header">';
        header += '<div class="collapse navbar-collapse">';
        header += '<div class="d-inline-flex justify-content-between w-100">';
        header += '<div>';
        header += '<button type="button" class="btn btn-dark" onclick="MPage()">Main page</button>';
        header += '<button type="button" class="btn btn-dark" id="browsing" onclick="ItemList()">Böngészés</button>';
        header += '</div>';
        header += '<div id="navlogin" class="d-inline-flex justify-content-end">';
        header += '<button type="button" class="btn btn-dark" id="profileButton" onclick="AdminInterface()">maintenance</button>';
        header += '<button type="button" class="btn btn-dark" id="profileButton" onclick="Profile()">Profile</button>';
        header += '<button type="button" class="btn btn-dark" id="profileButton" onclick="Logout()">Logout</button>';
        header += '<button type="button" class="btn btn-dark">Basket</button>';
        header += '</div>';
        header += '</div>';
        header += '</div>';
        header += '</nav>';
            break;
    
        default:
            break;
    }
    $("#header").replaceWith(header);
}

function MainF() {
    let footer = '';
    footer += '<div class="alert alert-dark " style="width:95%">';
    footer += '<footer>';
    footer += '<p>&copy; @DateTime.Now.Year - My ASP.NET Application</p>';
    footer += '<p id="footer-text"></p>';
    footer += '</footer>';
    footer += '</div>';
    $("#footer").append(footer);
}

//fejléc, lábléc
//$(document).change(function () {
//    $.ajax({
//        type: "GET",
//        url: "Item/loader",
//        cache: false,
//        success: function (data) {
//            //if (_cookie == data) {
//            //  alert("ugyanaz a süti, ideje ezt befejezni")
//            //}
//            let header = '';

//            $("#header-text").append(header);

//            let footer = '';
//            $("#footer-text").append(footer);

//        },
//        error: function (data) { alert("layout betöltés hiba " + data.status) }

//    });
//});

//ha a login gombra nyomsz először
function Login() {
    var html = "";
    $("#regbutton").remove();
    $("#perbutton").remove();
    $("#loginButton").attr("onclick", "LoginSend()");
    $("#loginButton").attr("class", "btn btn-dark disabled");
    html += '<form class="form-inline" id="login-form">';
    html += '<button class="btn btn-link text-secondary" id="regbutton" onclick="Register()">registration</button>';
    html += '<p class="btn text-secondary" style="margin:auto" id="perbutton">/</p>';
    html += '<button class="btn btn-link text-secondary" id="pwlink">Forgot your password?</button>';
    html += '<div class="form-group">';
    html += '<input type="text" class="form-control-sm p-2" id="email" placeholder="email@example.com">';
    html += '</div>';
    html += '<div class="form-group mx-sm-3">';
    html += '<input type="password" class="form-control-sm" id="password" placeholder="Password">';
    html += '</div>';
    html += '</form>';
    $("#navlogin").prepend(html);
    EmailkeyUp();
    PWKeyUp();
}

//a login egészét a regisztrációhoz készíti, működik alapállapotból is
function LoginRemover() {
    $("#regbutton").remove();
    $("#perbutton").remove();
    $('#login-form').remove();
    $("#loginButton").attr("onclick", "Login()");
    $("#loginButton").attr("class", "btn btn-dark");
}
function LoginDefault() {
    let header = "";
    header += '<div id="navlogin" class="d-inline-flex justify-content-end">';
    header += '<button type="button" class="btn btn-dark" id="loginButton" onclick="Login()">Login</button>';
    header += '<p class="btn btn-dark" style="margin:auto" id="perbutton">/</p>';
    header += '<button type="button" class="btn btn-dark" id="regbutton" onclick="Register()">registration</button>';
    //header+='<button type="button" class="btn btn-dark">Profile</button>';
    header += '<button type="button" class="btn btn-dark">Basket</button>';
    header += '</div>';
    $("#navlogin").replaceWith(header);
}

//login keyup csekkek
function EmailkeyUp() {
    $("#email").keyup(function () {
        LoginKeyup();
    });
}
function PWKeyUp() {
    $("#password").keyup(function () {
        LoginKeyup();
    });
}
function LoginKeyup() {
    if ($("#email").val().indexOf("@") > -1 && $("#email").val().indexOf(".") > -1 && $("#password").val().length >= 8) {
        $("#loginButton").attr("class", "btn btn-dark");
    }
    else {
        $("#loginButton").attr("class", "btn btn-dark disabled");
    }
}

function Register() {
    LoginRemover();
    $("#Container").empty();

    var html = "";

    html += '<div class="bg-light border border-dark rounded p-4">';
    html += '<form style="" class="mx-5">';
    html += '<label for="exampleInputEmail1">Name:</label>';
    html += '<div class="form-row mb-5">';
    html += '<div class="col mx-5">';
    html += '<input type="text" class="form-control" id="fn" placeholder="First name">';
    html += '</div>';
    html += '<div class="col mx-5">';
    html += '<input type="text" class="form-control" id="ln" placeholder="Last name">';
    html += '</div>';
    html += '</div>';
    html += '<label for="exampleInputEmail1">Email address:</label>';
    html += '<div class="form-row mb-5">';
    html += '<div class="col mx-5">';
    html += '<input type="text" class="form-control" placeholder="E-mail" id="email">';
    html += '</div>';
    html += '<div class="col mx-5">';
    html += '<input type="text" class="form-control disabled" placeholder="E-mail again">';
    html += '</div>';
    html += '</div>';
    html += '<label for="exampleInputEmail1">Password:</label>';
    html += '<div class="form-row mb-5">';
    html += '<div class="col mx-5">';
    html += '<input type="text" class="form-control" placeholder="Password" id="password">';
    html += '<small id="passwordHelpBlock" class="form-text text-muted ">';
    html += 'Your password must be 8-20 characters long, contain letters and numbers, special characters and must not contain spaces.';
    html += '</small>';
    html += '</div>';
    html += '<div class="col mx-5">';
    html += '<input type="text" class="form-control disabled" placeholder="Password again">';
    html += '</div>';
    html += '</div>';
    html += '<div class="form-row">';
    html += '<div class="col mx-5">';
    html += '<input class="form-check-input px-5" type="checkbox" value="" id="chkbox" onclick="terms()">';
    html += '<label class="form-check-label" for="invalidCheck">';
    html += 'Agree to terms and conditions';
    html += '</label>';
    html += '</div>';
    html += '<div class="col mx-5">';
    html += '<button class="btn btn-primary disabled" id="sbtn" onclick="RegisterSend()">Registration</button>';
    html += '</div>';
    html += '</div>';
    html += '</form>';
    html += '</div>';

    $("#Container").append(html);
}
function RegisterSend() {
    $.ajax({
        type: "POST",
        url: "Item/Registration",
        data: JSON.stringify({UserName: $("#fn").val()+' '+$("#ln").val(), Email: $("#email").val(), UserPassword: $("#password").val() }),
        dataType: 'json',
        contentType: 'application/json;',
        success: function (data) { },
        error: function (data) { alert(data.status) }
    });
}
///checking the checkbox in the register panel
function terms() {
    if ($("#chkbox").is(":checked")) {
        $("#sbtn").attr("class", "btn btn-primary");
    }
    else {
        $("#sbtn").attr("class", "btn btn-primary disabled");
    }
}

//login elküldése
function LoginSend() {
    $.ajax({
        type: "POST",
        url: "Item/Login",
        data: JSON.stringify({ email: $("#email").val(), UserPassword: $("#password").val() }),
        dataType: 'json',
        contentType: 'application/json;',
        success: function (data) { 
            if (data.status == "failedlogin") {
                alert("hibás e-mail vagy jelszó") 
            }
            else{
                location.reload();
            }
         },
        error: function (data) { alert(data.status) }
    });
    //alert("Dolgozz ki (^_^)");
    //$.post('Item/Login', {"UserName" : "asd", "Email" : "asd2"},
    //    function (returnedData) {
    //        alert("bent");
    //    });
}

function alma() {
    $.ajax({
        type: "GET",
        url: "Item/Time",
        cache: false,
        success: function (data) { $("#Container").append("<p>" + data + "</p>"); },
        error: function (data) { alert(data.status) }

    });
}

function Logout() {
    $.ajax({
        type: "POST",
        url: "Item/Logout",
        success: function (data) {location.reload();},
        error: function (data) { alert(data.status) }
    });
}

function AdminInterface() {
    $("#Container").replaceWith("<p>asd</p>");
}