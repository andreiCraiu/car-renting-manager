export default class UserVm {
  constructor(data) {
    if (!data) {
      return;
    }
    this.email = data.email;
    this.password = data.password;
  }
}
