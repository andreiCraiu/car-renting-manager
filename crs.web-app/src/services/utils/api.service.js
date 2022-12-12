import axios from "axios";

const ApiService = {
  async get(resource, params, config) {
    let fullResource = resource;
    if (params) {
      fullResource += params;
    }
    return await axios.get(fullResource, config);
  },

  async post(resource, data, config) {
    return await axios.post(resource, data, config);
  },

  async put(resource, data, config) {
    return await axios.put(resource, data, config);
  },

  delete(resource) {
    return axios.delete(resource);
  },
};

export { ApiService };
