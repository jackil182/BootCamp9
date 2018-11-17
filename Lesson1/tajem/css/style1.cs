*{
    margin: 0;
    padding: 0;
    /* outline: 2px solid red; */
}

.main, .footer, .container{
    width: 1600px;
}

.container{
    background-image: url("../img/bg1.png");
    padding-bottom: 70px;
}

li{
    list-style-type: none;
}

.header{
    padding-top: 10px;
    margin: 0 330px;
    height: 60px;
    line-height: 58px;
}

.menu-item{
    font-family: Roboto-Black, AdobeInvisFont, MyriadPro-Regular;
    font-size: 13pt;
    /* color: rgba(0, 224, 208, 255); */
    text-align: right;
    text-transform: uppercase;
    font-weight: 900;
}

.logo-header-footer{
    width: 120px;
    height: auto;
    float: left;
    margin-top: 5px;
}

.menu{
    float: right;
    color: white;
}

.clearfix{
    overflow: auto;
  }

.menu-item{
    display: inline-block;
    vertical-align: middle;
    margin: 0 5px;
}

.menu-item a{
    text-decoration: none;
    font-family: Roboto-Black, AdobeInvisFont, MyriadPro-Regular;
    font-size: 13px;
    color: white;
}

.slider{
    margin-top: 182px;
    color: white;
}

.main-title{
    text-align: center;
}

.main-title:after{
    content: "";
    display: block;
    width: 50px;
    height: 1px;
    background-color: rgba(0, 224, 208, 255);
    margin: 21px auto 0;
}

.slider-text{
    margin: 52px auto 0;
    text-align: center;
    width: 771px;
}

.more{
    display: block;
    width: 120px;
    margin: 50px auto 0px;
    padding: 15px;
    font-family: HammersmithOne-Regular, AdobeInvisFont, MyriadPro-Regular;
    font-size: 16px;
    font-weight: 600;
    color: rgba(0, 224, 208, 255);
    text-align: center;
    border: 2px solid rgba(0, 224, 208, 255);
    text-decoration: none;
}

.our-story{
    margin-bottom: 70px;
    font-size: 0px;
}

.story-logo{
    width: 229px;
    height: 235px;
    margin-top: 70px;
    margin-left: 395px;
    display: inline-block;
}

.title{
    font-family: PlayfairDisplay-Bold, AdobeInvisFont, MyriadPro-Regular;
    font-size: 22px;
    color: rgba(65, 61, 75, 255);
    text-transform: uppercase;
    padding-top: 70px;
}

.story-content{
    width: 538px;
    margin-left: 100px;
    display: inline-block;
    font-family: Roboto-Light, AdobeInvisFont, MyriadPro-Regular;
    font-size: 14px;
    color: rgba(65, 61, 75, 255);
    vertical-align: top;
}

.story-text{
    margin-top: 28px;
}

.left-alignment{
    margin-left: 0px;
}

.player{
    background-image: url("../img/bg2.png");
    height: 550px;
}

.player-text{
    margin-top: 34px;
    text-align: center;
}

.player-button{
    height: 100px;
    width: 100px;
    margin: 200px 750px 0;
    background-image: url("../img/player-button.png");
    background-color: rgba(255, 255, 255, 0);
    border: 0px;
}

.expertise{
    text-align: center;
}

.expertise-block{
    margin: 0 330px;
    display: grid;
    grid-template-columns: auto auto auto;
    grid-template-rows: auto auto;
}

.expertise-subtitle{
    font-family: PlayfairDisplay-Regular, AdobeInvisFont, MyriadPro-Regular;
    font-size: 14px;
    color: rgba(47, 45, 53, 255);
    margin-bottom: 70px;
}

.block-item{
    width: 313px;
    height: 250px;
}

.block-item__img{
    margin-top: 32px;
    height: 50px;
}

.block-item__title{
    margin-top: 35px;
    font-family: Roboto-Black, AdobeInvisFont, MyriadPro-Regular;
    font-size: 14px;
    color: rgba(65, 61, 75, 255);
    text-align: center;
}

.block-item__text{
    margin-top: 25px;
    margin-bottom: 40px ;
    font-family: Roboto-Light, AdobeInvisFont, MyriadPro-Regular;
    font-size: 14px;
    color: rgba(51, 51, 51, 255);
    text-align: center;
}

.white{
    color: white;
}

.team{
    background-image: url("../img/bg3.png");
    background-size: cover;
    text-align: center;
    color: rgba(255, 255, 255, 255);
    padding-bottom: 70px;
}

.subtitle{
    font-family: PlayfairDisplay-Regular, AdobeInvisFont, MyriadPro-Regular;
    font-size: 14px;
    color: rgba(249, 249, 249, 255);
    margin-top: 16px;
}

.team-list{
    display: grid;
    grid-template-columns: 220px 220px 220px 220px;
    grid-template-rows: 308px;
    grid-column-gap: 20px;
    margin: 67px 330px 0;
}

.team-item{
    /* margin-right: 20px; */
    border: 1px solid rgba(255, 255, 255, 0.226);
}

.team-item__img{
    width: 220px;
    height: 229px;
}

.team-item_name{
    margin-top: 20px;
    line-height: 0px;
    margin-bottom: 12px;
}

.team-item__position{
    margin-top: 12px;
    font-family: Roboto-Light, AdobeInvisFont, MyriadPro-Regular;
    font-size: 12px;
    font-weight: 100;
}

.team-text{
    margin-top: 70px;
}

.team .more{
    margin-top: 26px;
    width: 140px;
}

.our-works{
    text-align: center;
    padding-bottom: 70px;
}

.our-works__title{
    display: flex;
}

.left-title{
    margin-left: 330px;
}

.right-link{
    margin-left: 606px;
    margin-top: 70px;
    text-decoration: none;
    font-family: Roboto-Light, AdobeInvisFont, MyriadPro-Regular;
    font-size: 14px;
    color: rgba(65, 61, 75, 255);
}

.portfolio{
    display: flex;
    flex-wrap: wrap;
    justify-content: space-between;
    margin-top: 70px;
}

.portfolio__item{
    width: 266px;
    height: 200px;
    outline: 1px solid gray;
}

.testimonials{
    background-image: url("../img/bg4.png");
    background-size: cover;
    text-align: center;
    color: rgba(255, 255, 255, 255);
    padding-bottom: 70px;
}

.testimonials-text{
    margin: 0 415px;
    padding-top: 137px;
    font-family: PlayfairDisplay-Regular, AdobeInvisFont, MyriadPro-Regular;
    font-size: 16px;
    color: rgba(255, 255, 255, 255);
}

.testimonials-name{
    margin-top: 52px;
}

.testimonials-position{
    margin-top: 13px;
}

.testimonials-block{
    display: flex;
    margin: 0 547px;
    justify-content: center;
    margin-top: 45px;
    align-items: center;
}

.testimonials-photo{
    margin: 0 14px;
}

.good-news
{
    margin: 0 auto;
}

.footer{
    background-image: url("../img/bg5.png");
}