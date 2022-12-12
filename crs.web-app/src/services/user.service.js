import { apiUrl } from "../environement.js";
import { ApiService } from "./utils/api.service.js";

export const UserService = {
  async authenticate(data) {
    const requestConfig = {
      headers: {
        "Content-Type": "application/json",
      },
    };
    console.log(data, "data sent");
    const response = await ApiService.post(apiUrl, data, requestConfig);
    return response.data;
  },
};
