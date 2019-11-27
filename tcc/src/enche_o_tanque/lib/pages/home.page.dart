import 'package:enche_o_tanque/pages/diesel.page.dart';
import 'package:enche_o_tanque/pages/etanol.page.dart';
import 'package:enche_o_tanque/pages/gasolina.page.dart';
import 'package:enche_o_tanque/pages/login.page.dart';
import 'package:flutter/material.dart';

class HomePage extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text("Principal"),
      ),
      backgroundColor: Colors.green[600],
      body: Padding(
        padding: EdgeInsets.all(20),
        child: Center(
          child: Column(
            crossAxisAlignment: CrossAxisAlignment.stretch,
            mainAxisAlignment: MainAxisAlignment.center,
            children: <Widget>[
              SizedBox(
                child: Image.asset('assets/images/logo-eot-2.png'),
                width: 70,
                height: 70,
              ),
              SizedBox(
                height: 20,
              ),
              Container(
                height: 35,
                color: Colors.white,
                child: Row(
                  mainAxisAlignment: MainAxisAlignment.spaceAround,
                  children: <Widget>[
                    Image.asset('assets/images/location.png'),
                    Text("VIRADOURO - SP"),
                    Image.asset('assets/images/expand.png')
                  ],
                ),
              ),
              SizedBox(
                height: 25,
              ),
              Container(
                height: 70,
                color: Colors.white,
                child: Row(
                  mainAxisAlignment: MainAxisAlignment.spaceAround,
                  children: <Widget>[
                    SizedBox(
                      child: Image.asset('assets/images/gasolina.png'),
                      width: 60,
                      height: 60,
                    ),
                    Container(
                      child: Row(
                        children: <Widget>[
                          Text(
                            'R\$',
                            style: TextStyle(
                              color: Colors.grey[600],
                              fontSize: 20,
                            ),
                          ),
                          SizedBox(
                            width: 5,
                          ),
                          Text(
                            "4,21",
                            style: TextStyle(
                                color: Colors.grey[600],
                                fontSize: 50,
                                fontWeight: FontWeight.w900),
                          )
                        ],
                      ),
                    ),
                    Container(
                      child: FlatButton(
                        onPressed: () => {
                          Navigator.push(
                            context,
                            MaterialPageRoute(
                                builder: (context) => GasolinaPage()),
                          )
                        },
                        child: SizedBox(
                          height: 40,
                          width: 40,
                          child: Image.asset('assets/images/circle.png'),
                        ),
                      ),
                    ),
                  ],
                ),
              ),
              SizedBox(
                height: 15,
              ),
              Container(
                height: 70,
                color: Colors.white,
                child: Row(
                  mainAxisAlignment: MainAxisAlignment.spaceAround,
                  children: <Widget>[
                    SizedBox(
                      child: Image.asset('assets/images/etanol.png'),
                      width: 60,
                      height: 60,
                    ),
                    Container(
                      child: Row(
                        children: <Widget>[
                          Text(
                            'R\$',
                            style: TextStyle(
                              color: Colors.grey[600],
                              fontSize: 20,
                            ),
                          ),
                          SizedBox(
                            width: 5,
                          ),
                          Text(
                            "2,79",
                            style: TextStyle(
                                color: Colors.grey[600],
                                fontSize: 50,
                                fontWeight: FontWeight.w900),
                          )
                        ],
                      ),
                    ),
                    Container(
                      child: FlatButton(
                        onPressed: () => {
                          Navigator.push(
                            context,
                            MaterialPageRoute(
                                builder: (context) => EtanolPage()),
                          )
                        },
                        child: SizedBox(
                          height: 40,
                          width: 40,
                          child: Image.asset('assets/images/circle.png'),
                        ),
                      ),
                    ),
                  ],
                ),
              ),
              SizedBox(
                height: 15,
              ),
              Container(
                height: 70,
                color: Colors.white,
                child: Row(
                  mainAxisAlignment: MainAxisAlignment.spaceAround,
                  children: <Widget>[
                    SizedBox(
                      child: Image.asset('assets/images/diesel.png'),
                      width: 60,
                      height: 60,
                    ),
                    Container(
                      child: Row(
                        children: <Widget>[
                          Text(
                            'R\$',
                            style: TextStyle(
                              color: Colors.grey[600],
                              fontSize: 20,
                            ),
                          ),
                          SizedBox(
                            width: 5,
                          ),
                          Text(
                            "3,21",
                            style: TextStyle(
                                color: Colors.grey[600],
                                fontSize: 50,
                                fontWeight: FontWeight.w900),
                          )
                        ],
                      ),
                    ),
                    Container(
                      child: FlatButton(
                        onPressed: () => {
                          Navigator.push(
                            context,
                            MaterialPageRoute(
                                builder: (context) => DieselPage()),
                          )
                        },
                        child: SizedBox(
                          height: 40,
                          width: 40,
                          child: Image.asset('assets/images/circle.png'),
                        ),
                      ),
                    ),
                  ],
                ),
              ),
              SizedBox(
                height: 10,
              ),
              Container(
                height: 60,
                color: Colors.white,
                child: Center(
                  child: Text(
                    "P u b l i c i d a d e",
                    style: TextStyle(
                      color: Colors.grey,
                      fontSize: 15,
                    ),
                  ),
                ),
              )
            ],
          ),
        ),
      ),
    );
  }
}
