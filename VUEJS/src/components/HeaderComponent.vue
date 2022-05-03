<template>
<div class="header">
  <h1>Books storage application</h1>
  <MenuItems @emit-event="$emit('emit-event-header')"></MenuItems>
</div>
</template>

<script>
import MenuItems from "@/components/MenuItems";
export default {
  name: "HeaderComponent",
  components: {MenuItems}
}
</script>

<style scoped>
.header {
  background-color: bisque;
  padding: 60px;
  text-align: center;
  font-size: 30px;
}
</style>