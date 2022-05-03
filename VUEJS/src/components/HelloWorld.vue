<template>
  <div class="hello">
    <h1>{{ msg }}</h1>
  </div>

  <div id="app">
    <h1>Books</h1>
    <div>
      <p>Title: <input v-model="bookToAdd.title" type="text"/></p>
      <p>Is book read: <select v-model="bookToAdd.isRead">
        <option value="" selected disabled hidden>Choose here</option>
        <option value="bookRead">Yes</option>
        <option value="bookNotRead">No</option>
      </select>
      </p>
      <button  v-on:click="onAddClick(bookToAdd)">Add</button>
    </div>
    <div>
      <table>
        <thead>
        <tr>
          <td>Title</td>
          <td>IsRead</td>
        </tr>
        </thead>
        <tbody>
        <tr v-for="book in books" :key="book.title">
          <td class="title">
            {{book.title}}
          </td>
          <td v-if="book.isRead === 'bookRead'" class="read">{{book.isRead}}</td>
          <td v-else class="notRead">{{book.isRead}}</td>
        </tr>
        </tbody>
      </table>
    </div>
  </div>
</template>

<script>
export default {
  data() {
    return {
      books: [
        {title: 'Thinking, fast and slow', isRead: 'bookRead'},
        {title: 'Scrum Guide', isRead: 'bookNotRead'}
      ],
      bookToAdd: {title: '', isRead: ''}
    }
  },
  name: 'HelloWorld',
  props: {
    msg: String
  },
  methods: {
    onAddClick(book) {
      this.books.push({title: book.title, isRead: book.isRead});
    }
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
h3 {
  margin: 40px 0 0;
}
ul {
  list-style-type: none;
  padding: 0;
}
li {
  display: inline-block;
  margin: 0 10px;
}
a {
  color: #42b983;
}
table {
  margin-left: auto;
  margin-right: auto;
}
td {
  border: 1px solid black;
}

td.title {
  font-weight: bold;
}

td.read {
  background-color: green;
}

td.notRead{
  background-color: red;
}
</style>
