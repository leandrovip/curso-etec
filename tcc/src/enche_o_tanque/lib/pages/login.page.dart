import 'package:enche_o_tanque/pages/home.page.dart';
import 'package:flutter/material.dart';

class LoginPage extends StatefulWidget {
  @override
  _LoginPageState createState() => _LoginPageState();
}

class _LoginPageState extends State<LoginPage> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: Padding(
        padding: EdgeInsets.all(20),
        child: Center(
          child: Column(
            crossAxisAlignment: CrossAxisAlignment.stretch,
            mainAxisAlignment: MainAxisAlignment.center,
            children: <Widget>[
              SizedBox(
                width: 200,
                height: 200,
                child: Image.asset('assets/images/logo-eot.png'),
              ),
              SizedBox(
                height: 30,
              ),
              Center(
                child: Text(
                  "Abasteça com o melhor preço e com a qualidade que seu veículo merece :)",
                  textAlign: TextAlign.center,
                  style: TextStyle(),
                ),
              ),
              SizedBox(
                height: 40,
              ),
              ButtonTheme(
                height: 50.0,
                child: RaisedButton(
                  onPressed: () => {
                    Navigator.push(context,
                        MaterialPageRoute(builder: (context) => HomePage())),
                  },
                  child: Text(
                    "Iniciar Sessão",
                    style: TextStyle(
                      color: Colors.white,
                      fontWeight: FontWeight.bold,
                    ),
                  ),
                  color: Colors.green[600],
                ),
              ),
              SizedBox(
                height: 20,
              ),
              Divider(),
              SizedBox(
                height: 20,
              ),
              ButtonTheme(
                height: 50.0,
                child: RaisedButton(
                  onPressed: () => {},
                  child: Row(
                    mainAxisAlignment: MainAxisAlignment.spaceAround,
                    children: <Widget>[
                      Text("Login com Facebook",
                          style: TextStyle(
                            color: Colors.white,
                            fontWeight: FontWeight.bold,
                          ),
                          textAlign: TextAlign.left),
                      Container(
                        child: SizedBox(
                          child:
                              Image.asset('assets/images/botao-facebook.png'),
                          height: 30,
                          width: 30,
                        ),
                      ),
                    ],
                  ),
                  color: Colors.blue[800],
                ),
              ),
            ],
          ),
        ),
      ),
    );
  }
}
