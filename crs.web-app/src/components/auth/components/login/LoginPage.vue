<template>
  <div>
    <BaseCard
      cssClass="over text-center container col-md-4 mx-auto"
      title="Login"
    >
      <template #body-card>
        <div role="group">
          <b-form-input
            v-model="user.email"
            placeholder="User"
            type="email"
            trim
            class="mb-3 mt-5"
          ></b-form-input>
          <b-form-input
            v-model="user.password"
            placeholder="Password"
            trim
            type="password"
          ></b-form-input>
        </div>
        <div class="container">
          <div class="row">
            <div class="col text-center">
              <b-button
                href="#"
                variant="primary"
                class="mt-3"
                @click="authenticate"
                >Login</b-button
              >
            </div>
          </div>
        </div>
      </template>
    </BaseCard>
    <b-carousel
      id="carousel-fade"
      style="text-shadow: 0px 0px 2px #000"
      fade
      indicators
      img-width="200"
      img-height="200"
    >
      <b-carousel-slide>
        <template #img>
          <img
            class="d-block feet"
            src="https://focusrent.ro/wp-content/uploads/2016/12/rent_a_car_Bucuresti.jpg"
            alt="image slot"
          />
        </template>
      </b-carousel-slide>

      <b-carousel-slide>
        <template #img>
          <img
            class="d-block feet"
            src="https://i0.wp.com/rayhaber.com/wp-content/uploads/2022/03/Operasyonel-Arac-Kiralama-Sektoru-2021de-17-2-Milyar-TLlik-Yeni-Arac-Yatirimi-Yapti.jpg?resize=678%2C381&ssl=1"
            alt="image slot"
          />
        </template>
      </b-carousel-slide>

      <b-carousel-slide>
        <template #img>
          <img
            class="d-block feet"
            src="https://media.istockphoto.com/id/628453996/photo/close-up-of-a-man-receiving-new-car-key.jpg?s=612x612&w=0&k=20&c=RgK0qMS_bU-mFfZvqSxsPlUSVPY7vBamOV2IpO3JTc8="
            alt="image slot"
          />
        </template>
      </b-carousel-slide>
    </b-carousel>
  </div>
</template>
<script src="./login-page.ts"></script>
<style>
@import "./login-page.scss";
</style>
