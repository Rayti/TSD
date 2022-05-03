<template>
<table>
  <tr>
    <td v-on:click="$emit('emitEvent')">MenuItem1</td>
    <td>MenuItem2</td>
  </tr>
</table>
</template>

<script>
export default {
  name: "MenuItems"
}
</script>

<style scoped>
table {
  margin-left: auto;
  margin-right: auto;
}

table td {
  border: 2px solid #42b983;
  border-radius: 20px;
  padding: 10px;
}
table td:hover{
  background-color: aquamarine;
  font-weight: bold;
  border: 5px solid blue;
  border-radius: 20px;
  padding: 15px;
}
</style>