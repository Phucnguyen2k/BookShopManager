# BookShopManager

## Overview

### Login

![](https://i.imgur.com/kKjNp5g.png)

User Name: Yuri

- PassWord: 123
- Admin Password: Admin

```cs
BookShopDataContext db = new BookShopDataContext();

public static string UserName = "";
private void CheckLogin()
{
    string username = txtUserName.Text;
    string password = txtPassword.Text;

    var user = db.UserTbls.SingleOrDefault(u => u.UName == username && u.UPass == password);

    if (user != null)
    {
        UserName = user.UName;
        Billing obj = new Billing();
        obj.Show();
        this.Hide();
        NotificationHelper.ShowNotification("Login", "Login Successful", ToolTipIcon.Info);
    }
    else
    {
        MessageBox.Show("Wrong Username or Password", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
}
// Check Login and Password
private void btnLogin_Click(object sender, EventArgs e)
{
    CheckLogin();
}
```
- Hien Form Admin
```cs
private void label3_Click(object sender, EventArgs e)
{
    AdminLogin obj = new AdminLogin();
    obj.Show();
    this.Hide();
}

```
- An Password

```cs
private void Login_Load(object sender, EventArgs e)
{    
    btnShowPass.ImageIndex = 1;
}
```

```cs
private void btnShowPass_Click(object sender, EventArgs e)
{
    if (txtPassword.PasswordChar == '\0')
    {
        txtPassword.PasswordChar = '*';
        btnShowPass.ImageIndex = 1;
    }
    else
    {
        txtPassword.PasswordChar = '\0';
        btnShowPass.ImageIndex = 0;
    }
}
```

## Login Admin

![a](https://i.imgur.com/7rvDXnv.png)

PassWord: Admin

## Books

### Edits Books

![BookShopManager_KpLYLJtWjc.gif](./OverView/BookShopManager_KpLYLJtWjc.gif)

![a](https://i.imgur.com/nhUncRR.png)

### Filter Add Search Books

![BookShopManager_ufEKttWSCM.gif](./OverView/BookShopManager_ufEKttWSCM.gif)

![BookShopManager_tfGbi0mHZ7.gif](./OverView/BookShopManager_tfGbi0mHZ7.gif)

#### Filter

![a](https://i.imgur.com/2syDXFs.png)

#### Sort

![a](https://i.imgur.com/47zL8WC.png)

![BookShopManager_yWou7qKKJB.gif](./OverView/BookShopManager_yWou7qKKJB.gif)

## User

![a](https://i.imgur.com/RNxBoAR.png)

![BookShopManager_iZaS69uVmu.gif](./OverView/BookShopManager_iZaS69uVmu.gif)

## Dashboard

### Dashboard

![BookShopManager_vIP0bsEBc0.gif](./OverView/BookShopManager_vIP0bsEBc0.gif)

![a](https://i.imgur.com/wUmMjPT.png)

### History

![a](.\OverView\BookShopManager_g5ercbTdsb.png)

### Line

![a](.\OverView\BookShopManager_IZVDYjqsFh.png)

### Chart

![a](.\OverView\BookShopManager_CbPT3TX3AB.png)

## Bill

![BookShopManager_1U79ZIrwV8.gif](./OverView/BookShopManager_1U79ZIrwV8.gif)

![a](.\OverView\BookShopManager_pQ71b8nyuD.png)

### Print

![a](.\OverView\BookShopManager_wQS4XZyO5M.png)
