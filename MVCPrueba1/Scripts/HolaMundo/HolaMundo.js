var app = angular.module("MyApp", []);

app.controller("MyController", function ($scope, $http, $window) {


    $scope.DialogoJava = function () {

        var Dialogo = 
        {
            "Mensaje": "Mensaje Primero"
        };

        $http
            ({
                method: "POST",
                url: "/HolaMundo/MensajeHolaMundo",
                datatype: 'json',
                contentType: 'application/json; charset=utf-8',
                header: { "contentType": "application/json" },
                data:
                {
                    Dialogo: Dialogo
                }
            }).then(function (datos) {

                $scope.ListDialogo = datos.data;

                
            }
            , function (error) {

            });
    };
});