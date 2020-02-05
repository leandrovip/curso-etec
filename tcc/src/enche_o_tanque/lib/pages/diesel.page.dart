import 'package:flutter/material.dart';

class DieselPage extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text("Diesel"),
      ),
      backgroundColor: Colors.green[600],
      body: Padding(
        padding: EdgeInsets.all(20),
        child: Center(
          child: Column(
            crossAxisAlignment: CrossAxisAlignment.stretch,
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
                color: Colors.grey[700],
                height: 630,
                child: Column(
                  mainAxisAlignment: MainAxisAlignment.center,
                  children: <Widget>[
                    SizedBox(
                      height: 20,
                    ),
                    Text(
                      "Diesel",
                      style: TextStyle(
                        fontSize: 50,
                        color: Colors.white,
                        fontWeight: FontWeight.w800,
                      ),
                      textAlign: TextAlign.center,
                    ),
                    SizedBox(
                      height: 18,
                    ),
                    Row(
                      mainAxisAlignment: MainAxisAlignment.center,
                      children: <Widget>[
                        Text(
                          'R\$',
                          style: TextStyle(
                            color: Colors.white,
                            fontSize: 20,
                          ),
                        ),
                        SizedBox(
                          width: 5,
                        ),
                        Text(
                          "3,21",
                          style: TextStyle(
                              color: Colors.white,
                              fontSize: 50,
                              fontWeight: FontWeight.w900),
                          textAlign: TextAlign.center,
                        ),
                      ],
                    ),
                    SizedBox(
                      height: 40,
                    ),
                    Container(
                      color: Colors.white,
                      height: 320,
                      width: 400,
                      child: ListView(
                        children: <Widget>[
                          ListTile(
                            leading: Image.asset(
                              'assets/images/logo-br.png',
                            ),
                            title: Text('Posto  1'),
                            trailing: Icon(Icons.keyboard_arrow_right),
                          ),
                          ListTile(
                            leading: Image.asset(
                              'assets/images/logo-shell.png',
                            ),
                            title: Text('Posto  2'),
                            trailing: Icon(Icons.keyboard_arrow_right),
                          ),
                          ListTile(
                            leading: Image.asset(
                              'assets/images/logo-ipiranga.png',
                            ),
                            title: Text('Posto  3'),
                            trailing: Icon(Icons.keyboard_arrow_right),
                          ),
                        ],
                      ),
                    )
                  ],
                ),
              ),
              SizedBox(
                height: 40,
              ),
              Text(
                "P U B L I C I D A D E",
                style: TextStyle(
                  color: Colors.white,
                  fontSize: 14,
                ),
                textAlign: TextAlign.center,
              )
            ],
          ),
        ),
      ),
    );
  }
}
