<template>
  <b-card :class="cssClass" class="resize" :title="title">
    <slot name="body-card"> </slot>
  </b-card>
</template>
<script>
import { BCard } from "bootstrap-vue";
export default {
  name: "BaseCard",
  components: {
    BCard,
  },
  props: {
    cssClass: { type: [String, Object] },
    title: { type: [String, Object] },
  },
  data() {
    return {};
  },
};
</script>

<style lang="scss" scoped>
@media screen and (max-width: 1400px) {
  .resize {
    width: 50%;
  }
}
@media screen and (max-width: 775px) {
  .resize {
    width: 90%;
  }
}
</style>
