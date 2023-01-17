import { BCarouselSlide, BFormInput } from "bootstrap-vue";
import BaseCard from "../../../../base-components/BaseCard.vue";
import { UserService } from "../../../../services/user.service";
import UserVm from "../../view-models/userVm";

export default {
  name: "LoginPage",
  components: {
    BCarouselSlide,
    BFormInput,
    BaseCard,
  },
  data() {
    return {
      user: {
        email: "",
        password: "",
      },
    };
  },
  methods: {
    async authenticate() {
      let userVm = new UserVm();
      userVm.email = this.user.email;
      userVm.password = this.user.password;
      await UserService.authenticate(userVm);
      this.user = null;
    },
  },
};
