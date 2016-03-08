$(function () {
    var gameHub;

    $.connection.hub.start().done(function () {
        gameHub = $.connection.gameHub;

        gameHub.server.ping().done(function (result) {
            console.debug(result);
        });
    });
});