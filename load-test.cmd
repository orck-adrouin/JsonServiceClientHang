@ECHO OFF

ECHO.
ECHO ==================================================================
ECHO Warm up
ECHO ==================================================================
ECHO.

ab -c 1 -n 1 -d -S http://localhost:20247/widgets/list?format=json |find "per"
ab -c 1 -n 1 -d -S http://localhost:20690/widgets/list?format=json |find "per"

:: ECHO.
:: ECHO ==================================================================
:: ECHO Make 3000 get using 100 concurrent connection directly on the backend
:: ECHO ==================================================================
:: ECHO. 
:: 
:: ab -c 50 -n 1000 -d -S http://localhost:20690/widgets/list?format=json |find "per"

ECHO.
ECHO ==================================================================
ECHO Make 10000 get using 50 concurrent connection directly on the gateway
ECHO ==================================================================
ECHO. 

ab -c 20 -n 400 -d -S http://localhost:20247/widgets/list?format=json
ab -c 20 -n 400 -d -S http://localhost:20247/widget/mywidgetname?format=json
ab -c 20 -n 400 -d -S http://localhost:20247/widgets/list?format=json
ab -c 20 -n 400 -d -S http://localhost:20247/widget/mywidgetname?format=json
ab -c 20 -n 400 -d -S http://localhost:20247/widgets/list?format=json
ab -c 20 -n 400 -d -S http://localhost:20247/widget/mywidgetname?format=json

:: |find "per"
:: |find "per"
:: ab -c 50 -n 1000 -d -S http://localhost:20247/widgets/list?format=json |find "per"



ECHO END
PAUSE

